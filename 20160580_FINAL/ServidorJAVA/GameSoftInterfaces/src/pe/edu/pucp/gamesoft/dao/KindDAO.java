package pe.edu.pucp.gamesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Kind;

public interface KindDAO extends java.rmi.Remote{
    ArrayList<Kind> queryAll()throws java.rmi.RemoteException;
}