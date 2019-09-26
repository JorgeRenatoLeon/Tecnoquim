/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lp2tecnoquim.dao;

import java.util.ArrayList;
import lp2tecnoquim.model.DetalleAlmacenInsumo;


/**
 *
 * @author alulab14
 */
public interface DetalleAlmacenInsumoDAO {
    void insertar(DetalleAlmacenInsumo trabajador);
    void actualizar(DetalleAlmacenInsumo trabajador);
    void eliminar(int id);
    ArrayList<DetalleAlmacenInsumo> listar();
}
