package cse423.labs.lab1.task;

import com.jogamp.opengl.GL2;
import com.jogamp.opengl.GLAutoDrawable;
import com.jogamp.opengl.GLCapabilities;
import com.jogamp.opengl.GLEventListener;
import com.jogamp.opengl.GLProfile;
import com.jogamp.opengl.awt.GLCanvas;
import javax.swing.JFrame;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;

public class Lab01no02 implements GLEventListener{

    static GLProfile profile = GLProfile.get(GLProfile.GL2);
    static GLCapabilities capabilities = new GLCapabilities(profile);
    static GLCanvas glcanvas = new GLCanvas(capabilities);
    static String[] words = new String[20];

    public static void main(String[] args) throws Exception{
        //getting the capabilities object of GL2 profile
        String values;
        File file = new File("coordinates.txt");
        FileReader fileReader = new FileReader(file);
        BufferedReader br = new BufferedReader(fileReader);
        try{
            for (int j = 0; !((values = br.readLine()) == null); j += 1){
                words [j] = values;
            }
        } catch(Exception e){
            System.out.println("Empty File");
        }
        setValue(words);


        Lab01no02 geometry = new Lab01no02();
        glcanvas.addGLEventListener(geometry);
        glcanvas.setSize(700, 500);


        final JFrame frame = new JFrame ("StraightLine");
        frame.getContentPane().add(glcanvas);
        frame.setSize(frame.getContentPane().getPreferredSize());
        frame.setVisible(true);
    }

    public static void setValue(String[] array){
        array = words;
    }

    public static String[] getValue(){
        return words;
    }



    public void dispose(GLAutoDrawable arg0) {
        //method body
    }


    public void init(GLAutoDrawable drawable) {
        // method body
        //4. drive the display() in a loop
    }

    public void display(GLAutoDrawable drawable) {
        final GL2 gl = drawable.getGL().getGL2();
        String[] words = getValue();
        gl.glColor3d(1, 1, 0);
        gl.glPointSize(7);
        gl.glBegin (GL2.GL_POINTS);
        for(int i = 0; i <= 19; i++) {
            gl.glVertex2d(
                    Double.valueOf(words [i].split(" ")[0]).doubleValue(),
                    Double.valueOf(words [i].split(" ")[1]).doubleValue()
            );
        }
        gl.glEnd();
    }

    public void reshape(GLAutoDrawable arg0, int arg1, int arg2, int arg3, int arg4) {
    }
}