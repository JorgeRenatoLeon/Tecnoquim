package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.model.Kind;
import pe.edu.pucp.gamesoft.model.LevelUpMove;
import pe.edu.pucp.gamesoft.model.Pokemon;
import pe.edu.pucp.gamesoft.model.Range;
import pe.edu.pucp.gamesoft.model.Type;

public class PokemonMySQL extends java.rmi.server.UnicastRemoteObject implements PokemonDAO{

    Connection con;
    CallableStatement cs;
    
    public PokemonMySQL() throws RemoteException{
        
    }
    @Override
    public ArrayList<Pokemon> queryAll(String name) throws RemoteException{
        ArrayList<Pokemon> pokemons = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call QUERY_ALL_POKEMON(?)}");
            cs.setString("_NAME", name);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Pokemon pokemon = new Pokemon();
                pokemon.setIdPokemon(rs.getInt("ID_POKEMON"));
                pokemon.setName(rs.getString("POKEMON_NAME"));
                pokemon.setNationalDexNumber(rs.getString("NATIONAL_POKEDEX_NUMBER"));
                pokemon.getType1().setIdType(rs.getInt("FID_TYPE_1"));
                pokemon.getType1().setName(rs.getString("TYPE1_NAME"));
                pokemon.getType1().setRedValue(rs.getInt("TYPE1RED"));
                pokemon.getType1().setGreenValue(rs.getInt("TYPE1GREEN"));
                pokemon.getType1().setBlueValue(rs.getInt("TYPE1BLUE"));
                pokemon.getType2().setIdType(rs.getInt("FID_TYPE_2"));
                pokemon.getType2().setName(rs.getString("TYPE2_NAME"));
                pokemon.getType2().setRedValue(rs.getInt("TYPE2RED"));
                pokemon.getType2().setGreenValue(rs.getInt("TYPE2GREEN"));
                pokemon.getType2().setBlueValue(rs.getInt("TYPE2BLUE"));
                pokemon.setHeight(rs.getDouble("HEIGHT"));
                pokemon.setWeight(rs.getDouble("WEIGHT"));
                pokemon.setDescription(rs.getString("DESCRIPTION"));
                pokemon.setPhoto(rs.getBytes("PHOTO"));
                pokemons.add(pokemon);
            }
            for(Pokemon pokemon : pokemons){
                cs = con.prepareCall("{call QUERY_ALL_MOVES_BY_POKEMONID(?)}");
                cs.setInt("_ID_POKEMON", pokemon.getIdPokemon());
                rs = cs.executeQuery();
                while(rs.next()){
                    LevelUpMove lvlMove = new LevelUpMove();
                    lvlMove.setIdLevelUpMove(rs.getInt("ID_LEVEL_UP_MOVE"));
                    lvlMove.setMoveName(rs.getString("NAME_MOVE"));
                    lvlMove.setPower(rs.getInt("POWER"));
                    lvlMove.setLevelOfLearning(rs.getInt("LEVEL_OF_LEARNING"));
                    lvlMove.setType(new Type());
                    lvlMove.getType().setIdType(rs.getInt("FID_TYPE"));
                    lvlMove.getType().setName(rs.getString("TYPE_NAME"));
                    lvlMove.getType().setRedValue(rs.getInt("RED_VALUE"));
                    lvlMove.getType().setGreenValue(rs.getInt("GREEN_VALUE"));
                    lvlMove.getType().setBlueValue(rs.getInt("BLUE_VALUE"));
                    lvlMove.setKind(new Kind());
                    lvlMove.getKind().setIdKind(rs.getInt("FID_KIND"));
                    lvlMove.getKind().setMovementKind(rs.getString("MOVEMENT_KIND"));
                    lvlMove.setRange(new Range());
                    lvlMove.getRange().setIdRange(rs.getInt("FID_RANGE"));
                    lvlMove.getRange().setMovementRange(rs.getString("MOVEMENT_RANGE"));
                    lvlMove.setAccuracy(rs.getInt("ACCURACY"));
                    lvlMove.setPowerPoint(rs.getInt("POWER_POINT"));
                    pokemon.getLevelUpMoves().add(lvlMove);
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return pokemons;
    }

    @Override
    public int insert(Pokemon pokemon) throws RemoteException{
        int resultado = 0;
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            cs = con.prepareCall("{call INSERT_POKEMON(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID_POKEMON", java.sql.Types.INTEGER);
            cs.setString("_NATIONAL_POKEDEX_NUMBER", pokemon.getNationalDexNumber());
            cs.setString("_POKEMON_NAME", pokemon.getName());
            cs.setInt("_FID_TYPE_1", pokemon.getType1().getIdType());
            cs.setInt("_FID_TYPE_2", pokemon.getType2().getIdType());
            cs.setDouble("_HEIGHT", pokemon.getHeight());
            cs.setDouble("_WEIGHT", pokemon.getWeight());
            cs.setString("_DESCRIPTION", pokemon.getDescription());
            cs.setBytes("_PHOTO", pokemon.getPhoto());
            cs.executeUpdate();
            pokemon.setIdPokemon(cs.getInt("_ID_POKEMON"));
            for(LevelUpMove lvlUpMove : pokemon.getLevelUpMoves()){
                cs = con.prepareCall("{call INSERT_LVL_UP_MOVE(?,?,?,?,?,?,?,?,?)}");
                cs.setInt("_FID_POKEMON", pokemon.getIdPokemon());
                cs.setInt("_LEVEL_OF_LEARNING", lvlUpMove.getLevelOfLearning());
                cs.setString("_NAME_MOVE", lvlUpMove.getMoveName());
                cs.setInt("_FID_TYPE", lvlUpMove.getType().getIdType());
                cs.setInt("_FID_KIND", lvlUpMove.getKind().getIdKind());
                cs.setInt("_POWER", lvlUpMove.getPower());
                cs.setInt("_ACCURACY", lvlUpMove.getAccuracy());
                cs.setInt("_POWER_POINT", lvlUpMove.getPowerPoint());
                cs.setInt("_FID_RANGE", lvlUpMove.getRange().getIdRange());
                cs.executeUpdate();
            }
            resultado = pokemon.getIdPokemon();
            con.commit();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            try{con.rollback();resultado=0;}catch(Exception exe){System.out.println(exe.getMessage());}
        }finally{
            try{con.setAutoCommit(true);con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int update(Pokemon pokemon) throws RemoteException{
        int resultado = 0;
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            cs = con.prepareCall("{call UPDATE_POKEMON(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_ID_POKEMON", pokemon.getIdPokemon());
            cs.setString("_NATIONAL_POKEDEX_NUMBER", pokemon.getNationalDexNumber());
            cs.setString("_POKEMON_NAME", pokemon.getName());
            cs.setInt("_FID_TYPE_1", pokemon.getType1().getIdType());
            cs.setInt("_FID_TYPE_2", pokemon.getType2().getIdType());
            cs.setDouble("_HEIGHT", pokemon.getHeight());
            cs.setDouble("_WEIGHT", pokemon.getWeight());
            cs.setString("_DESCRIPTION", pokemon.getDescription());
            cs.setBytes("_PHOTO", pokemon.getPhoto());
            cs.executeUpdate();
            cs = con.prepareCall("{call DELETE_MOVES_BY_IDPOKEMON(?)}");
            cs.setInt("_ID_POKEMON", pokemon.getIdPokemon());
            cs.executeUpdate();
            for(LevelUpMove lvlUpMove : pokemon.getLevelUpMoves()){
                cs = con.prepareCall("{call INSERT_LVL_UP_MOVE(?,?,?,?,?,?,?,?,?)}");
                cs.setInt("_FID_POKEMON", pokemon.getIdPokemon());
                cs.setInt("_LEVEL_OF_LEARNING", lvlUpMove.getLevelOfLearning());
                cs.setString("_NAME_MOVE", lvlUpMove.getMoveName());
                cs.setInt("_FID_TYPE", lvlUpMove.getType().getIdType());
                cs.setInt("_FID_KIND", lvlUpMove.getKind().getIdKind());
                cs.setInt("_POWER", lvlUpMove.getPower());
                cs.setInt("_ACCURACY", lvlUpMove.getAccuracy());
                cs.setInt("_POWER_POINT", lvlUpMove.getPowerPoint());
                cs.setInt("_FID_RANGE", lvlUpMove.getRange().getIdRange());
                cs.executeUpdate();
            }
            con.commit();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            try{con.rollback();resultado=0;}catch(Exception exe){System.out.println(exe.getMessage());}
        }finally{
            try{con.setAutoCommit(true);con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int delete(int idPokemon) throws RemoteException{
        int resultado = 0;
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call DELETE_POKEMON(?)}");
            cs.setInt("_ID_POKEMON", idPokemon);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
