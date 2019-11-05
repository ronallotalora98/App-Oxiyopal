import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Ng2SmartTableModule } from 'ng2-smart-table';

import { OxiyopalRoutingModule } from './oxiyopal-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ThemeModule } from '../../@theme/theme.module';
import { NbMenuModule, NbCardModule, NbIconModule, NbButtonModule } from '@nebular/theme';
import { ControlCilindroComponent } from './control-cilindro/control-cilindro.component';
import { AddCilindroComponent } from './cilindros/add-cilindro/add-cilindro.component';

@NgModule({
  declarations: [
    DashboardComponent,
    OxiyopalLayaudComponent,
    ControlCilindroComponent,
    AddCilindroComponent],
  imports: [
    ThemeModule,
    NbMenuModule,
    CommonModule,
    OxiyopalRoutingModule,
    Ng2SmartTableModule,
    NbCardModule,
    NbIconModule,
    NbButtonModule,
  ],
})
export class OxiyopalModule { }
