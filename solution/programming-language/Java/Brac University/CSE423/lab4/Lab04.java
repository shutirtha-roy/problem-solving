import com.jogamp.opengl.GL2;
import com.jogamp.opengl.GLAutoDrawable;
import com.jogamp.opengl.GLCapabilities;
import com.jogamp.opengl.GLEventListener;
import com.jogamp.opengl.GLProfile;
import com.jogamp.opengl.awt.GLCanvas;
import com.jogamp.opengl.glu.GLU;
import javax.swing.JFrame;

public class Lab04 implements GLEventListener{
    private GLU glu;



    public void display(GLAutoDrawable drawable) {
        GL2 gl = drawable.getGL().getGL2();
        gl.glClear(GL2.GL_COLOR_BUFFER_BIT);

        //2
        int radius = 12;
        int shifter = 30;
        int upShift = 15;
        gl.glPushMatrix();
        drawMidPointCircle(gl, -110 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, -94 + shifter, 26 + upShift, radius);
        drawMidPointCircle(gl, -78 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, -64 + shifter, 8 + upShift, radius);
        drawMidPointCircle(gl, -64 + shifter, -16 + upShift, radius);
        drawMidPointCircle(gl, -74 + shifter, -30 + upShift, radius);
        drawMidPointCircle(gl, -84 + shifter, -50 + upShift, radius);
        drawMidPointCircle(gl, -94 + shifter, -60 + upShift, radius);
        drawMidPointCircle(gl, -110 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, -94 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, -78 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, -64 + shifter, -70 + upShift, radius);


        //8
        drawMidPointCircle(gl, 35 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, 15 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, -1 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, -20 + shifter, -70 + upShift, radius);
        drawMidPointCircle(gl, 35 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, 15 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, -1 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, -20 + shifter, 18 + upShift, radius);
        drawMidPointCircle(gl, 35 + shifter, -26 + upShift, radius);
        drawMidPointCircle(gl, 15 + shifter, -26 + upShift, radius);
        drawMidPointCircle(gl, -1 + shifter, -26 + upShift, radius);
        drawMidPointCircle(gl, -20 + shifter, -26 + upShift, radius);
        drawMidPointCircle(gl, -20 + shifter, -48 + upShift, radius);
        drawMidPointCircle(gl, 35 + shifter, -48 + upShift, radius);
        drawMidPointCircle(gl, -20 + shifter, -5 + upShift, radius);
        drawMidPointCircle(gl, 35 + shifter, -5 + upShift, radius);
    }

    public void dispose(GLAutoDrawable arg0) {
        //method body
    }

    public void init(GLAutoDrawable gld) {

        GL2 gl = gld.getGL().getGL2();
        glu = new GLU();

        gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        gl.glViewport(-100, -50, 50, 100);
        gl.glMatrixMode(GL2.GL_PROJECTION);
        gl.glLoadIdentity();
        glu.gluOrtho2D(-100.0, 100.0, -100.0, 100.0);

    }


    public void reshape(GLAutoDrawable drawable, int x, int y, int width,
                        int height) {
    }


    private void drawMidPointCircle(GL2 gl, int x1 , int y1 ,int r) {

        gl.glPointSize(1.0f);
        gl.glColor3d(1, 0, 0);

        int x = 0;
        int y = r;
        int d = 1 -  r;

        drawcircle(gl , x , y , x1 , y1);

        while (x < y) {
            if (d < 0) {
                d = d + ((2 * x + 3) * 4);
                x++;
            }

            else {
                d = d + ((2 * x - 2 * y + 5) * 4);
                x++;
                y--;
            }

            drawcircle(gl , x , y , x1 , y1);


        }
    }




    private void drawcircle(GL2 gl, int x, int y, int x1, int y1) {
        gl.glBegin(GL2.GL_POINTS);
        gl.glVertex2d(x+x1, y+y1);
        gl.glVertex2d(y+x1, x+y1);

        gl.glVertex2d(-x+x1, y+y1);
        gl.glVertex2d(-y+x1, x+y1);

        gl.glVertex2d(-x+x1, -y+y1);
        gl.glVertex2d(-y+x1, -x+y1);


        gl.glVertex2d(x+x1, -y+y1);
        gl.glVertex2d(y+x1, -x+y1);
        gl.glEnd();

    }




    public static void main(String[] args) {
        //getting the capabilities object of GL2 profile
        final GLProfile profile = GLProfile.get(GLProfile.GL2);
        GLCapabilities capabilities = new GLCapabilities(profile);
        // The canvas
        final GLCanvas glcanvas = new GLCanvas(capabilities);
        Lab04 l = new Lab04();
        glcanvas.addGLEventListener(l);
        glcanvas.setSize(400, 400);
        //creating frame
        final JFrame frame = new JFrame ("straight Line");
        //adding canvas to frame
        frame.getContentPane().add(glcanvas);
        frame.setSize(frame.getContentPane().getPreferredSize());
        frame.setVisible(true);
    }//end of main
}//end of classimport javax.media.opengl.GL2;
