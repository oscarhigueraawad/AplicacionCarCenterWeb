import { Component, Input, OnInit, Injectable } from '@angular/core';
import { ClientesServiceService } from 'src/app/services/clientes-service.service';

@Component({
  selector: 'acme-listclientes',
  templateUrl: './listclientes.component.html',
  styleUrls: ['./listclientes.component.css']
})
export class ListclientesComponent implements OnInit {
  public listclientes: any;
  public currentIndex = -1;
  public nombre = '';
  rowData: any[] = [];
  public currentCliente = {
    Documento: '',
    TipoDocumento: '',
    PrimerNombre: '',
    SegundoNombre: '',
    PrimerApellido: '',
    SegundoApellido: '',
    NoCelular: '',
    Direccion: '',
    CorreoElectronico: ''
  };

  public publishing = false;

  columnDefs = [
    { headerName: 'Documento', field: 'documento' },
    { headerName: 'TipoDocumento', field: 'tipoDocumento', editable: true },
    { headerName: 'PrimerNombre', field: 'primerNombre', editable: true },
    { headerName: 'SegundoNombre', field: 'segundoNombre', editable: true },
    { headerName: 'PrimerApellido', field: 'primerApellido', editable: true },
    { headerName: 'SegundoApellido', field: 'segundoApellido', editable: true },
    { headerName: 'NoCelular', field: 'noCelular', editable: true },
    { headerName: 'Direccion', field: 'direccion', editable: true },
    { headerName: 'CorreoElectronico', field: 'correoElectronico', editable: true },
  ];

  gridOptions = {
    onRowDoubleClicked: this.updateRegistro
  }

  constructor(private clientesService: ClientesServiceService) { }

  ngOnInit(): void {
    this.retrieveClientes();
  }

  retrieveClientes(): void {
    this.clientesService.getAll()
      .subscribe(
        data => {
          this.rowData = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }


  updateRegistro(row: any) {
    this.clientesService.update(row.documento, row)
    console.log(row);
  }


  refreshList(): void {
    this.retrieveClientes();
    this.currentIndex = -1;
    this.limpiarRegistro();
  }

  setActiveClientes(index: number): void {
    this.currentIndex = index;
  }


  searchCedula(): void {
    this.clientesService.findByCedula(this.nombre)
      .subscribe(
        data => {
          this.listclientes = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  limpiarRegistro(): void {
    this.listclientes = {
      Documento: '',
      TipoDocumento: '',
      PrimerNombre: '',
      SegundoNombre: '',
      PrimerApellido: '',
      SegundoApellido: '',
      NoCelular: '',
      Direccion: '',
      CorreoElectronico: '',
    };
  }
}
