import { Routes, RouterModule } from '@angular/router';
import { OxiClientesComponent } from '../clientes/oxi-clientes.component';
import { TipoCilindroComponent } from './tipo-cilindro/tipo-cilindro.component';
import { AddCilindroComponent } from './add-cilindro/add-cilindro.component';
import { ListCilindrosComponent } from './list-cilindros/list-cilindros.component';
import { EditCilidrosComponent } from './edit-cilindros/edit-cilidros.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
  {
    path: 'cilindros',
    component: OxiClientesComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OxiCilindrosRoutingModule { }

