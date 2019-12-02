package pe.edu.pucp.gamesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Range;

public interface RangeDAO extends java.rmi.Remote{
    ArrayList<Range> queryAll()throws java.rmi.RemoteException;
}