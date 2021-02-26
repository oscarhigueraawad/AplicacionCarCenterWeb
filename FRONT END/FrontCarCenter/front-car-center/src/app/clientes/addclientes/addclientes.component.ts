import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Cliente } from 'src/app/cliente';
import { ClientesServiceService } from 'src/app/services/clientes-service.service';

@Component({
  selector: 'acme-addclientes',
  templateUrl: './addclientes.component.html',
  styleUrls: ['./addclientes.component.css']
})
export class AddclientesComponent implements OnInit {
  public title = 'SISTEMA CAR CENTER WEB';
  public clientes = {
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
  submitted = false;

  constructor(private clientesService: ClientesServiceService) { }

  ngOnInit(): void {
  }

  saveClientes(): void {
    console.log(this.clientes.Documento);
    const data = {
      Documento: this.clientes.Documento,
      TipoDocumento: this.clientes.TipoDocumento,
      PrimerNombre: this.clientes.PrimerNombre,
      SegundoNombre: this.clientes.SegundoNombre,
      PrimerApellido: this.clientes.PrimerApellido,
      SegundoApellido: this.clientes.SegundoApellido,
      NoCelular: this.clientes.NoCelular,
      Direccion: this.clientes.Direccion,
      CorreoElectronico: this.clientes.CorreoElectronico
    };

    this.clientesService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
        
        this.newClientes();
  }

  newClientes(): void {
    this.submitted = false;
    this.clientes = {
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
