package pe.edu.pucp.gamesoft.config;

import java.rmi.RemoteException;
import pe.edu.pucp.gamesoft.config.MySQLDAOFactory;
import pe.edu.pucp.gamesoft.dao.KindDAO;
import pe.edu.pucp.gamesoft.dao.PokemonDAO;
import pe.edu.pucp.gamesoft.dao.RangeDAO;
import pe.edu.pucp.gamesoft.dao.TypeDAO;

public abstract class DAOFactory {
    
    public abstract KindDAO getKindDAO() throws RemoteException;
    public abstract TypeDAO getTypeDAO() throws RemoteException;
    public abstract RangeDAO getRangeDAO() throws RemoteException;
    public abstract PokemonDAO getPokemonDAO() throws RemoteException;
    
    public static DAOFactory getDAOFactory(){
        return new MySQLDAOFactory();
    }
}
