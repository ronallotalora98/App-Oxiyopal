import { Routes, RouterModule } from '@angular/router';
import { OxiClientesComponent } from './oxi-clientes.component';
import { AddClienteComponent } from './add-cliente/add-cliente.component';
import { ListClienteComponent } from './list-cliente/list-cliente.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
  {
    path: 'clientes',
    component: OxiClientesComponent,
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OxiClientesRoutingModule { }

