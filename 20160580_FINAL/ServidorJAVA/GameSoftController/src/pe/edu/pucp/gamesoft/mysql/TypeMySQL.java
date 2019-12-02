package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.TypeDAO;
import pe.edu.pucp.gamesoft.model.Type;

public class TypeMySQL extends java.rmi.server.UnicastRemoteObject implements TypeDAO{
    
    Connection con;
    CallableStatement cs;
    
    public TypeMySQL() throws RemoteException{
        
    }
    
    @Override
    public ArrayList<Type> queryAll()throws RemoteException{
        ArrayList<Type> tipos = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call QUERY_ALL_TYPES()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Type tipo = new Type();
                tipo.setIdType(rs.getInt("ID_TYPE"));
                tipo.setName(rs.getString("TYPE_NAME"));
                tipo.setRedValue(rs.getInt("RED_VALUE"));
                tipo.setGreenValue(rs.getInt("GREEN_VALUE"));
                tipo.setBlueValue(rs.getInt("BLUE_VALUE"));
                tipos.add(tipo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return tipos;
    }
}
