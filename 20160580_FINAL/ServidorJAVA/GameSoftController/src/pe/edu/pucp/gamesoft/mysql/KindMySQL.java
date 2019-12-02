package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.KindDAO;
import pe.edu.pucp.gamesoft.model.Kind;

public class KindMySQL extends java.rmi.server.UnicastRemoteObject implements KindDAO{

    Connection con;
    CallableStatement cs;
    
    public KindMySQL() throws RemoteException{
        
    }
    
    @Override
    public ArrayList<Kind> queryAll() throws RemoteException{
        ArrayList<Kind> categorias = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call QUERY_ALL_KINDS()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Kind kind = new Kind();
                kind.setIdKind(rs.getInt("ID_MOVEMENT_KIND"));
                kind.setMovementKind(rs.getString("MOVEMENT_KIND"));
                categorias.add(kind);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return categorias;
    }
    
}
