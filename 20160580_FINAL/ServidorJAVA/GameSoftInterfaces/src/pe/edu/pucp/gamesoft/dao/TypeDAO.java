package pe.edu.pucp.gamesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Type;

public interface TypeDAO extends java.rmi.Remote{
    ArrayList<Type> queryAll()throws java.rmi.RemoteException;
}