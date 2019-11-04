import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';

const routes: Routes = [
  {
    path: '',
    component: OxiyopalLayaudComponent,
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'oxi', redirectTo: '/dashboard' },
    ],
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OxiyopalRoutingModule { }
