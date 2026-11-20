# RentaCar Express
---

Aplicación de escritorio diseñada para registrar alquileres de vehículos, y calcular el total a pagar.


## Datos del Autor
- **Nombre:** Andy Williams Rijo Báez
- **Matrícula:** 2025-0114

---

## Datos de Entrada
- **Cliente (`TextBox`):** Nombre del cliente que solicita el alquiler.
- **Cliente corporativo (`CheckBox`):** Indica si aplica el descuento corporativo del 15%.
- **Fecha de salida (`DateTimePicker`):** Fecha programada para el inicio del alquiler.
- **Vehículo (`TextBox`):** Modelo o descripción del vehículo a alquilar.
- **Tarifa diaria (`TextBox`):** Costo base por día del vehículo en pesos dominicanos (RD$).
- **Días (`NumericUpDown`):** Cantidad de días que durará el alquiler.
- **Tipo de seguro (`RadioButton`):** Selección entre seguro *Básico* (sin costo adicional) o *Completo* (+RD$ 300.00 por día).
- **Modalidad de entrega (`RadioButton`):** Selección entre retiro en *Sucursal* (sin costo adicional) o envío a *Domicilio* (+RD$ 500.00).
- **GPS (`CheckBox`):** Accesorio adicional opcional (+RD$ 100.00 por día).

---

## Datos que Procesa
- **Cálculo por vehículo:** Suma los cargos diarios opcionales (Seguro Completo y/o GPS) a la tarifa base y multiplica el resultado por la cantidad de días (`totalLinea = tarifaDiaria * dias`).
- **Acumulación del subtotal:** Añade cada vehículo al detalle de alquileres (`ListBox`) y acumula su costo en el subtotal general.
- **Descuento corporativo:** Si el cliente es corporativo, calcula un descuento del **15%** sobre el subtotal (`subtotal * 0.15`).
- **Cargo por entrega:** Si se selecciona entrega a domicilio, suma un cargo fijo de **RD$ 500.00**.
- **Cálculo de impuestos (ITBIS):** Calcula el **18%** sobre la base imponible (`(subtotal - descuento + domicilio) * 0.18`).
- **Total a pagar:** Suma la base imponible más el ITBIS calculado.

---

## Datos de Salida
La interfaz muestra el detalle tabulado de cada vehículo agregado en el listado (**Días**, **Vehículo**, **Tarifa** y **Total**) y presenta en pantalla el desglose financiero formateado en moneda local (`RD$`):
- **Subtotal**
- **Descuento**
- **Domicilio**
- **ITBIS (18%)**
- **TOTAL A PAGAR**

---

## Capturas de Pantalla

### Caso 1:
<img width="788" height="479" alt="image" src="https://github.com/user-attachments/assets/6f246e66-7fdf-4e18-9872-4210f2db73e8" />

### Caso 2:
<img width="790" height="476" alt="image" src="https://github.com/user-attachments/assets/1a179efd-4b16-4757-881b-db1fab17fa44" />
