/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio.MySQL;

import Dominio.Usuario;
import Servicio.IUsuario;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author nicolas
 */
public class UsuarioMySql extends MySql implements IUsuario {

    @Override
    public void Guardar(Usuario u) {
        strSQL = "INSERT INTO usuario(id, pass) VALUES ('" + u.getId() + "','" + u.getPass() + "')";
        update(strSQL);
    }

    @Override
    public boolean Borrar(String id) {
        strSQL = "DELETE FROM usuario WHERE id = " + id;
        update(strSQL);
        return true;
    }

    @Override
    public Usuario Buscar(String id) {
        return null;
    }

    @Override
    public List<Usuario> Usuarios() {
        List<Usuario> usuarios = new ArrayList<Usuario>();
        Usuario u = null;
        this.seleccionar("SELECT * FROM usuario");
        try {
            while (rs.next()) {
                u = new Usuario(rs.getString("id"),
                        rs.getString("pass"));
                usuarios.add(u);
            }
            rs.close();
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
        return usuarios;
    }

    @Override
    public void Modificar(Usuario u) {
        strSQL = "UPDATE usuario SET pass ='" + u.getPass() + "' WHERE id=" + u.getId();
        update(strSQL);
    }

}
