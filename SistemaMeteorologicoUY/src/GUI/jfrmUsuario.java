/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package GUI;

import Dominio.Usuario;
import Servicio.Fachada;
import javax.swing.DefaultListModel;
import java.util.ArrayList;
import javax.swing.JOptionPane;

/**
 *
 * @author nicolas
 */
public class jfrmUsuario extends javax.swing.JFrame {

    Fachada fachada;

    /**
     * Creates new form jfrmUsuario
     */
    public jfrmUsuario() {
        initComponents();
        fachada = Fachada.getInstancia();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jlblInCoMet = new javax.swing.JLabel();
        jlblBienvenido = new javax.swing.JLabel();
        jbtnComenzar = new javax.swing.JButton();
        jlblIniciarSesion = new javax.swing.JLabel();
        jlblUsuario = new javax.swing.JLabel();
        jlblContraseña = new javax.swing.JLabel();
        jtxtUsuario = new javax.swing.JTextField();
        jtxtContraseña = new javax.swing.JTextField();
        jbtnRegistrarse = new javax.swing.JButton();
        jlblCrearCuenta = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jlblInCoMet.setFont(new java.awt.Font("Gill Sans Ultra Bold", 0, 36)); // NOI18N
        jlblInCoMet.setText("InCoMet");

        jlblBienvenido.setText("Bienvenido/s al programa de InCoMet");

        jbtnComenzar.setText("COMENZAR");
        jbtnComenzar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnComenzarActionPerformed(evt);
            }
        });

        jlblIniciarSesion.setText("Iniciar Sesión");

        jlblUsuario.setText("Usuario:");

        jlblContraseña.setText("Contraseña:");

        jtxtUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jtxtUsuarioActionPerformed(evt);
            }
        });

        jtxtContraseña.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jtxtContraseñaActionPerformed(evt);
            }
        });

        jbtnRegistrarse.setText("REGISTRARSE");
        jbtnRegistrarse.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnRegistrarseActionPerformed(evt);
            }
        });

        jlblCrearCuenta.setText("No tiene cuenta? Desea crearse una? ");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(54, 54, 54)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jlblBienvenido)
                            .addComponent(jlblInCoMet, javax.swing.GroupLayout.PREFERRED_SIZE, 195, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jlblCrearCuenta)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(42, 42, 42)
                                .addComponent(jbtnRegistrarse))
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(jbtnComenzar)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                        .addComponent(jlblContraseña)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jtxtContraseña))
                                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                        .addComponent(jlblUsuario)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jtxtUsuario, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE))))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(107, 107, 107)
                        .addComponent(jlblIniciarSesion)))
                .addContainerGap(35, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jlblInCoMet, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jlblBienvenido)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jlblIniciarSesion)
                .addGap(10, 10, 10)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jlblUsuario)
                    .addComponent(jtxtUsuario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jlblContraseña)
                    .addComponent(jtxtContraseña, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(jbtnComenzar)
                .addGap(53, 53, 53)
                .addComponent(jlblCrearCuenta)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jbtnRegistrarse)
                .addContainerGap(18, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbtnComenzarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnComenzarActionPerformed
        int usuarios = 0;
        double resto = 0;
        ArrayList unaLista = (ArrayList) fachada.getUsuarioCRUD().Usuarios();
        for (int i = 0; i < unaLista.size(); i++) {
            Usuario tmpUsu = (Usuario) unaLista.get(i);
            if (tmpUsu.getId().equals(this.jtxtUsuario.getText()) && tmpUsu.getPass().equals(this.jtxtContraseña.getText())) {
                usuarios = usuarios + 1;
                jfrmOpciones unOpciones = new jfrmOpciones();
                unOpciones.setVisible(true);
                this.setVisible(false);
            } else {
                usuarios = usuarios + 2;
            }
        }
        resto = usuarios % 2;
        if (resto != 0) {
            JOptionPane.showMessageDialog(null, "Se ingreso correctamente");
        } else {
            JOptionPane.showMessageDialog(null, "Usuario o Contraeña incorrecta");
        }
    
    }//GEN-LAST:event_jbtnComenzarActionPerformed

    private void jtxtUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jtxtUsuarioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jtxtUsuarioActionPerformed

    private void jtxtContraseñaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jtxtContraseñaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jtxtContraseñaActionPerformed

    private void jbtnRegistrarseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnRegistrarseActionPerformed
        jfrmRegistrarse unFrm=new jfrmRegistrarse();
        unFrm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jbtnRegistrarseActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jbtnComenzar;
    private javax.swing.JButton jbtnRegistrarse;
    private javax.swing.JLabel jlblBienvenido;
    private javax.swing.JLabel jlblContraseña;
    private javax.swing.JLabel jlblCrearCuenta;
    private javax.swing.JLabel jlblInCoMet;
    private javax.swing.JLabel jlblIniciarSesion;
    private javax.swing.JLabel jlblUsuario;
    private javax.swing.JTextField jtxtContraseña;
    private javax.swing.JTextField jtxtUsuario;
    // End of variables declaration//GEN-END:variables
}
