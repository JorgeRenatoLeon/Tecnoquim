/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lp2tecnoquim.dao;

import java.util.ArrayList;
import lp2tecnoquim.model.PoliticaStock;


/**
 *
 * @author alulab14
 */
public interface PoliticaStockDAO {
    
    void insertar(PoliticaStock politica);
    void actualizar(PoliticaStock politica);
    void eliminar(int id);
    ArrayList<PoliticaStock> listar();
    
}
