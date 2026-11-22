#include <stdio.h>
#include <string.h>

#define maximo 100

enum tipos {
    electronicos = 1,
    ropa,
    alimentos,
};

union detalles {
    int garantia;
    char talla[15];
    char fecha_de_caducidad[15];
};

struct productos {
    float precio;
    int stock;
    char nombre[50];
    enum tipos tipo;
    union detalles detalle;
};

void agregar_productos(struct productos producto[], int *cantidad1);
void mostrar_productos(struct productos producto[], int cantidad);
void valor_productos(struct productos producto[], int cantidad);

int main() {
    int opcion;
    int cantidad1 = 0;
    struct productos producto[maximo];
    
    printf("Bienvenido administrador \n");

    do {
        printf("Elija una opcion: 1(agregar un nuevo producto), 2(mostrar productos disponibles), 3(mostrar el valor de los productos), 4(salir del programa) \n");
        scanf("%d", &opcion);
        
        switch (opcion) {
            case 1:
                agregar_productos(producto, &cantidad1);
                break;
            case 2:
                mostrar_productos(producto, cantidad1);
                break;
            case 3:
                valor_productos(producto, cantidad1);
                break;
            case 4:
                printf("Saliendo del programa\n");
                break;
            default:
                printf("Opción inválida, por favor elija nuevamente.\n");
                break;
        }
    } while (opcion != 4);
    
    return 0;
}

void agregar_productos(struct productos producto[], int *cantidad1) {
    struct productos productos1;
    int opcion2;

    printf("Ingrese el nombre del producto: ");
    scanf("%s", productos1.nombre);

    printf("Ingrese el precio del producto: ");
    scanf("%f", &productos1.precio);

    printf("Ingrese el stock del producto: ");
    scanf("%d", &productos1.stock);
     
    printf("Elija la categoría a la que pertenece 1(alimentos), 2(electronicos), 3(ropa): ");
    scanf("%d", &opcion2);
    
    productos1.tipo = opcion2; 

    if (opcion2 == alimentos) {
        printf("Ingrese la fecha de caducidad (dd/mm/yyyy): ");
        scanf("%s", productos1.detalle.fecha_de_caducidad);
    } else if (opcion2 == ropa) {
        printf("Ingrese la talla: ");
        scanf("%s", productos1.detalle.talla);
    } else if (opcion2 == electronicos) {
        printf("Ingrese el periodo de garantía en meses: ");
        scanf("%d", &productos1.detalle.garantia);
    }

    
    producto[*cantidad1] = productos1;
    (*cantidad1)++; 
}

void mostrar_productos(struct productos producto[], int cantidad) {
    if (cantidad == 0) {
        printf("No hay productos registrados.\n");
        return;
    }

    printf("Productos registrados:\n");
    for (int i = 0; i < cantidad; i++) {
        printf("Producto %d:\n", i + 1);
        printf("Nombre: %s\n", producto[i].nombre);
        printf("Precio: %.2f\n", producto[i].precio);
        printf("Stock: %d\n", producto[i].stock);
        printf("Categoría: %d\n", producto[i].tipo);
    
        switch (producto[i].tipo) {
            case electronicos:
                printf("Garantía: %d meses\n", producto[i].detalle.garantia);
                break;
            case ropa:
                printf("Talla: %s\n", producto[i].detalle.talla);
                break;
            case alimentos:
                printf("Fecha de caducidad: %s\n", producto[i].detalle.fecha_de_caducidad);
                break;
        }
        printf("\n");
    }
}

void valor_productos(struct productos producto[], int cantidad) {
    if (cantidad == 0) {
        printf("No hay productos registrados.\n");
        return;
    }

    printf("Valor de los productos registrados:\n");
    for (int i = 0; i < cantidad; i++) {
        printf("Nombre: %s, Precio: %.2f\n", producto[i].nombre, producto[i].precio);
    }
}

    
