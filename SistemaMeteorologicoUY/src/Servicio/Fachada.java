/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import Dominio.Registro;
import Servicio.MySQL.UsuarioMySql;
import Servicio.MySQL.RegistroMySql;

/**
 *
 * @author Usuario
 */
public class Fachada {
    
    private static Fachada instancia;
    private IUsuario usuarioCRUD;
    private IRegistro registroCRUD;

    public Fachada() {
        usuarioCRUD = new UsuarioMySql();
        registroCRUD = new RegistroMySql();
    }
    
    public static Fachada getInstancia() {
        if (instancia == null) {
            instancia = new Fachada();
        }
        return instancia;
    }

    public IUsuario getUsuarioCRUD() {
        return usuarioCRUD;
    }
    
    public IRegistro getRegistroCRUD() {
        return registroCRUD;
    }
    
    int IdMostrar;
    public void agarrarIdDepartamento(int Id) {
        IdMostrar = Id;
    }
    
    public int devolverIdDepartamento() {
        return IdMostrar;
    }
}
