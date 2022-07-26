/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import Dominio.Registro;
import java.util.List;

/**
 *
 * @author Usuario
 */
public interface IRegistro {
    
    public void Guardar(Registro r);

    public void Modificar(Registro r);

    public boolean Borrar(int id);

    public Registro Buscar(int id);

    public List<Registro> Registros();
}
