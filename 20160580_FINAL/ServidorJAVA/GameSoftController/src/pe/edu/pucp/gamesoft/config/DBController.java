package pe.edu.pucp.gamesoft.config;

import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DAOFactory;
import pe.edu.pucp.gamesoft.model.Kind;
import pe.edu.pucp.gamesoft.model.Pokemon;
import pe.edu.pucp.gamesoft.model.Range;
import pe.edu.pucp.gamesoft.model.Type;

public abstract class DBController {    
    private static final DAOFactory daoFactory = new MySQLDAOFactory();
    
    public static ArrayList<Kind> listarTodasCategorias() throws RemoteException{
        return daoFactory.getKindDAO().queryAll();
    }
    
    public static ArrayList<Type> listarTodosTipos() throws RemoteException{
        return daoFactory.getTypeDAO().queryAll();
    }
    
    public static ArrayList<Range> listarTodosRangos() throws RemoteException{
        return daoFactory.getRangeDAO().queryAll();
    }
    
    public static int insertarPokemon(Pokemon pokemon) throws RemoteException{
        return daoFactory.getPokemonDAO().insert(pokemon);
    }
    
    public static ArrayList<Pokemon> listarPokemons(String name) throws RemoteException{
        return daoFactory.getPokemonDAO().queryAll(name);
    }
    
    public static int eliminarPokemon(int idPokemon) throws RemoteException{
        return daoFactory.getPokemonDAO().delete(idPokemon);
    }
    
    public static int modificarPokemon(Pokemon pokemon) throws RemoteException{
        return daoFactory.getPokemonDAO().update(pokemon);
    }
}
