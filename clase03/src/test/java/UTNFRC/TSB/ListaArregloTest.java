package UTNFRC.TSB;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import java.math.*;

class ListaArregloTest {

    private int[] source = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
    private ListaArreglo testSource;
    private ListaArreglo testSourceVacio;

    @BeforeEach
    void setUp()
    {
        testSourceVacio = new ListaArreglo();
        testSource = new ListaArreglo(source);
    }

    @Test
    void getCantidad()
    {
        assertArrayEquals(new int[]{0, source.length}, new int[] {testSourceVacio.getCantidad(), testSource.getCantidad()});

    }

    @Test
    void agregar() {
        testSource.agregar(11);
        assertArrayEquals(new int[]{11, 11} , new int[] {testSource.getCantidad(), testSource.getItem(10)});
        testSourceVacio.agregar(1);
        assertArrayEquals(new int[]{1, 1} , new int[] {testSourceVacio.getCantidad(), testSourceVacio.getItem(0)});

    }

    @Test
    void getItem()
    {
        int idxInicio = 0;
        int idxFinal = source.length - 1;
        int idxAleatorio = (int) (Math.random() * source.length);

        assertEquals(source[idxInicio], testSource.getItem(idxInicio));
        assertEquals(source[idxFinal], testSource.getItem(idxFinal));
        assertEquals(source[idxAleatorio], testSource.getItem(idxAleatorio));

    }

    @Test
    void getItemNegativo()
    {
        int idxInicio = source.length * -1;
        int idxFinal = - 1;
        int idxAleatorio = ((int) (Math.random() * source.length + 1) + 1) * -1;
        int idxInicioPositivo = idxInicio + source.length;
        int idxFinalPositivo = idxFinal + source.length;
        int idxAleatorioPositivo = idxAleatorio + source.length;

        assertEquals(source[idxInicioPositivo], testSource.getItem(idxInicio));
        assertEquals(source[idxFinalPositivo], testSource.getItem(idxFinal));
        assertEquals(source[idxAleatorioPositivo], testSource.getItem(idxAleatorio));


    }

    @Test
    void setItem()
    {
        int idxInicio = 0;
        int idxFinal = source.length - 1;
        int idxAleatorio = (int) (Math.random() * source.length);

        testSource.setItem(-99, idxInicio);
        assertEquals(-99, testSource.getItem(idxInicio));

        testSource.setItem(-99, idxFinal);
        assertEquals(-99, testSource.getItem(idxFinal));

        testSource.setItem(-99, idxAleatorio);
        assertEquals(-99, testSource.getItem(idxAleatorio));

    }

    @Test
    void setItemNegativo()
    {
        int idxInicio = source.length * -1;
        int idxFinal = - 1;
        int idxAleatorio = ((int) (Math.random() * source.length + 1) + 1) * -1;

        testSource.setItem(-99, idxInicio);
        assertEquals(-99, testSource.getItem(idxInicio));

        testSource.setItem(-99, idxFinal);
        assertEquals(-99, testSource.getItem(idxFinal));

        testSource.setItem(-99, idxAleatorio);
        assertEquals(-99, testSource.getItem(idxAleatorio));

    }


    @Test
    void setItemInsert()
    {
        int cantidadAnterior = testSource.getCantidad();

        testSource.setItem(-99, source.length);
        assertEquals(cantidadAnterior + 1, testSource.getCantidad());
        assertEquals(-99, testSource.getItem(source.length));

        testSourceVacio.setItem(-99, 0);
        assertEquals(1, testSourceVacio.getCantidad());
        assertEquals(-99, testSourceVacio.getItem(0));

    }

    @Test
    void insertar()
    {
        int cantidadAnterior = testSource.getCantidad();

        int idxAleatorio = (int) (Math.random() * source.length -1);

        testSource.insertar(-99, idxAleatorio);

        assertEquals(cantidadAnterior + 1, testSource.getCantidad());
        assertEquals(-99, testSource.getItem(idxAleatorio));
        assertEquals(source[idxAleatorio], testSource.getItem(idxAleatorio + 1));

    }

    @Test
    void insertarNegativo()
    {
        int cantidadAnterior = testSource.getCantidad();

        int idxAleatorio = ((int) (Math.random() * (source.length)) + 1) * -1;

        testSource.insertar(-99, idxAleatorio);

        assertEquals(cantidadAnterior + 1, testSource.getCantidad());
        assertEquals(-99, testSource.getItem(idxAleatorio));
        int idxPositivo = idxAleatorio + source.length;
        assertEquals(-99, testSource.getItem(idxPositivo));
        assertEquals(source[idxPositivo], testSource.getItem(idxPositivo + 1));

    }

    @Test
    void quitar()
    {
        int cantidadAnterior = testSource.getCantidad();

        int idxAleatorio = (int) (Math.random() * source.length -1);

        testSource.quitar(idxAleatorio);

        assertEquals(cantidadAnterior - 1, testSource.getCantidad());
        assertEquals(source[idxAleatorio + 1], testSource.getItem(idxAleatorio));

    }

    @Test
    void quitarNegativo()
    {
        int cantidadAnterior = testSource.getCantidad();

        int idxAleatorio = ((int) (Math.random() * (source.length)) + 1) * -1;
        int idxAleatorioPositivo = idxAleatorio + source.length;

        testSource.quitar(idxAleatorio);

        assertEquals(cantidadAnterior - 1, testSource.getCantidad());
        assertEquals(source[idxAleatorioPositivo + 1], testSource.getItem(idxAleatorioPositivo));
    }

    @Test
    void limpiar()
    {
        testSource.limpiar();
        assertEquals(0, testSource.getCantidad());

    }
}