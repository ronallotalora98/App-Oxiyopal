import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ControlCilindroComponent } from './control-cilindro/control-cilindro.component';
import { AddCilindroComponent } from './cilindros/add-cilindro/add-cilindro.component';
import { ListCilindrosComponent } from './cilindros/list-cilindros/list-cilindros.component';
import { AddClienteComponent } from './clientes/add-cliente/add-cliente.component';
import { ListClienteComponent } from './clientes/list-cliente/list-cliente.component';

const routes: Routes = [
  {
    path: '',
    component: OxiyopalLayaudComponent,
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'oxi', redirectTo: '/dashboard' },
      { path: 'cilindros', component: ControlCilindroComponent },
      { path: 'new-cilindro', component: AddCilindroComponent },
      { path: 'list-cilindros/:type', component: ListCilindrosComponent },
      { path: 'new-cliente', component: AddClienteComponent },
      { path: 'list-clientes', component: ListClienteComponent },
    ],
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OxiyopalRoutingModule { }
