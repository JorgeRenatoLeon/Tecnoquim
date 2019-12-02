package pe.edu.pucp.gamesoft.config;

import java.rmi.RemoteException;
import pe.edu.pucp.gamesoft.dao.KindDAO;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.dao.RangeDAO;
import pe.edu.pucp.gamesoft.dao.TypeDAO;
import pe.edu.pucp.gamesoft.mysql.KindMySQL;
import pe.edu.pucp.gamesoft.mysql.PokemonMySQL;
import pe.edu.pucp.gamesoft.mysql.RangeMySQL;
import pe.edu.pucp.gamesoft.mysql.TypeMySQL;

public class MySQLDAOFactory extends DAOFactory{
    public MySQLDAOFactory(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
        }catch(ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
    }
    
    @Override
    public KindDAO getKindDAO() throws RemoteException {
        return new KindMySQL();
    }
    
    @Override
    public TypeDAO getTypeDAO() throws RemoteException{
        return new TypeMySQL();
    }
    
    @Override
    public RangeDAO getRangeDAO() throws RemoteException{
        return new RangeMySQL();
    }
    
    @Override
    public PokemonDAO getPokemonDAO() throws RemoteException{
        return new PokemonMySQL();
    }
}
