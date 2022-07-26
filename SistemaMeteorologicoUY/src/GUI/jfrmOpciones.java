/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package GUI;

import Servicio.Fachada;
import com.panamahitek.ArduinoException;
import com.panamahitek.PanamaHitek_Arduino;
import com.panamahitek.PanamaHitek_MultiMessage;
import java.util.logging.Level;
import java.util.logging.Logger;
import jssc.SerialPortEvent;
import jssc.SerialPortEventListener;
import jssc.SerialPortException;

/**
 *
 * @author Usuario1
 */
public class jfrmOpciones extends javax.swing.JFrame {

    public jfrmOpciones() {
        
        initComponents();
        }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    
    
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jlblOpciones = new javax.swing.JLabel();
        jbtnAgregar = new javax.swing.JButton();
        jbtnMostrar = new javax.swing.JButton();
        jbtnModificar = new javax.swing.JButton();
        jbtnVolver = new javax.swing.JButton();
        jbtnEliminar1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jlblOpciones.setFont(new java.awt.Font("Gill Sans Ultra Bold", 0, 36)); // NOI18N
        jlblOpciones.setText("Opciones");

        jbtnAgregar.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jbtnAgregar.setText("Agregar");
        jbtnAgregar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnAgregarActionPerformed(evt);
            }
        });

        jbtnMostrar.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jbtnMostrar.setText("Mostrar");
        jbtnMostrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnMostrarActionPerformed(evt);
            }
        });

        jbtnModificar.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jbtnModificar.setText("Modificar");
        jbtnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnModificarActionPerformed(evt);
            }
        });

        jbtnVolver.setText("VOLVER");
        jbtnVolver.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnVolverActionPerformed(evt);
            }
        });

        jbtnEliminar1.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jbtnEliminar1.setText("Eliminar");
        jbtnEliminar1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnEliminar1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(42, 42, 42)
                        .addComponent(jlblOpciones))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(26, 26, 26)
                        .addComponent(jbtnVolver)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jbtnMostrar, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jbtnAgregar, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jbtnModificar)
                            .addComponent(jbtnEliminar1, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(61, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jlblOpciones, javax.swing.GroupLayout.PREFERRED_SIZE, 57, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jbtnAgregar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jbtnModificar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jbtnEliminar1)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jbtnVolver)
                        .addContainerGap())
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jbtnMostrar)
                        .addContainerGap(33, Short.MAX_VALUE))))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbtnMostrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnMostrarActionPerformed
        jfrmMostrar unFrm=new jfrmMostrar();
        unFrm.setVisible(true);
        this.setVisible(false);       
    }//GEN-LAST:event_jbtnMostrarActionPerformed

    private void jbtnAgregarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnAgregarActionPerformed
        jfrmAgregar unFrm=new jfrmAgregar();
        unFrm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jbtnAgregarActionPerformed

    private void jbtnVolverActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnVolverActionPerformed
        jfrmUsuario unFrm=new jfrmUsuario();
        unFrm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jbtnVolverActionPerformed

    private void jbtnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnModificarActionPerformed
        jfrmBuscarModificar unFrm=new jfrmBuscarModificar();
        unFrm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jbtnModificarActionPerformed

    private void jbtnEliminar1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnEliminar1ActionPerformed
        jfrmEliminar unFrm=new jfrmEliminar();
        unFrm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jbtnEliminar1ActionPerformed

   

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jbtnAgregar;
    private javax.swing.JButton jbtnEliminar1;
    private javax.swing.JButton jbtnModificar;
    private javax.swing.JButton jbtnMostrar;
    private javax.swing.JButton jbtnVolver;
    private javax.swing.JLabel jlblOpciones;
    // End of variables declaration//GEN-END:variables
}
