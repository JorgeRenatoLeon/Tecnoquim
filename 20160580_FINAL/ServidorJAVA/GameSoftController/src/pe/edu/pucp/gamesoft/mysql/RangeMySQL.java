package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.RangeDAO;
import pe.edu.pucp.gamesoft.model.Range;

public class RangeMySQL extends java.rmi.server.UnicastRemoteObject implements RangeDAO{

    Connection con;
    CallableStatement cs;
    
    public RangeMySQL() throws RemoteException{
        
    }
    
    @Override
    public ArrayList<Range> queryAll() throws RemoteException{
        ArrayList<Range> rangos = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call QUERY_ALL_RANGES()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Range range = new Range();
                range.setIdRange(rs.getInt("ID_MOVEMENT_RANGE"));
                range.setMovementRange(rs.getString("MOVEMENT_RANGE"));
                rangos.add(range);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return rangos;
    }
    
}
