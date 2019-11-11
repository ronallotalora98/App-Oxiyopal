import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ControlCilindroComponent } from './control-cilindro/control-cilindro.component';
import { AddCilindroComponent } from './cilindros/add-cilindro/add-cilindro.component';
import { ListCilindrosComponent } from './cilindros/list-cilindros/list-cilindros.component';

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
    ],
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OxiyopalRoutingModule { }
