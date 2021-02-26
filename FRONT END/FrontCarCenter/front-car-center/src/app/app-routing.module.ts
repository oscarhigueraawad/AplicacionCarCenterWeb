import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListclientesComponent } from './clientes/listclientes/listclientes.component';
import { DetailclientesComponent } from './clientes/detailclientes/detailclientes.component';
import { AddclientesComponent } from './clientes/addclientes/addclientes.component';

const routes: Routes = [
  { path: '', redirectTo: 'listclientes', pathMatch: 'full' },
  { path: 'listclientes', component: ListclientesComponent },
  { path: 'detailsclientes/:id', component: DetailclientesComponent },
  { path: 'adicionar', component: AddclientesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }