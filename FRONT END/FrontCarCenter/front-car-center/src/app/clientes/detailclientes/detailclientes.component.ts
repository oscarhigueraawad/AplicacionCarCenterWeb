import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientesServiceService } from 'src/app/services/clientes-service.service';

@Component({
  selector: 'acme-detailclientes',
  templateUrl: './detailclientes.component.html',
  styleUrls: ['./detailclientes.component.css']
})
export class DetailclientesComponent implements OnInit {
  public message = '';
  public published = false;
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

  constructor(
    private clientesService: ClientesServiceService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.message = '';
    let id = this.route.snapshot.params.id;
    let idd = this.route.snapshot.queryParams.id;
    this.getCliente(id);
  }

  getCliente(id: String): void {
    this.clientesService.get(id)
      .subscribe(
        data => {
          this.currentCliente = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  updatePublished(status: boolean): void {
    this.published = status;
    const data = {
      Documento: this.currentCliente.Documento,
      TipoDocumento: this.currentCliente.TipoDocumento,
      PrimerNombre: this.currentCliente.PrimerNombre,
      SegundoNombre: this.currentCliente.SegundoNombre,
      PrimerApellido: this.currentCliente.PrimerApellido,
      SegundoApellido: this.currentCliente.SegundoApellido,
      NoCelular: this.currentCliente.NoCelular,
      Direccion: this.currentCliente.Direccion,
      CorreoElectronico: this.currentCliente.CorreoElectronico
    };

    this.clientesService.update(this.currentCliente.Documento, data)
      .subscribe(
        response => {
          console.log(response);
        },
        error => {
          console.log(error);
        });
  }

  updateCliente(): void {
    this.clientesService.update(this.currentCliente.Documento, this.currentCliente)
      .subscribe(
        response => {
          console.log(response);
          this.message = 'Actualización Exitosa!';
        },
        error => {
          console.log(error);
        });
  }

  deleteCliente(): void {
    this.clientesService.delete(this.currentCliente.Documento)
      .subscribe(
        response => {
          console.log(response);
          this.router.navigate(['/listclientes']);
        },
        error => {
          console.log(error);
        });
  }
}

