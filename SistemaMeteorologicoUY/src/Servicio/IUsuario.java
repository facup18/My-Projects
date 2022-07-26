/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import Dominio.Usuario;
import java.util.List;

/**
 *
 * @author Usuario
 */
public interface IUsuario {
    
    public void Guardar(Usuario u);

    public void Modificar(Usuario u);

    public boolean Borrar(String id);

    public Usuario Buscar(String id);

    public List<Usuario> Usuarios();
}
