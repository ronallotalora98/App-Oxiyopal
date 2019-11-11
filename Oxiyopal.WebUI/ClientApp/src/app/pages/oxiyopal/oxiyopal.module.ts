import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Ng2SmartTableModule } from 'ng2-smart-table';

import { OxiyopalRoutingModule } from './oxiyopal-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ThemeModule } from '../../@theme/theme.module';
import { NbMenuModule, NbCardModule, NbIconModule, NbButtonModule,
   NbInputModule, NbCheckboxModule, NbRadioModule, NbSelectModule, NbToastrModule } from '@nebular/theme';
import { ControlCilindroComponent } from './control-cilindro/control-cilindro.component';
import { AddCilindroComponent } from './cilindros/add-cilindro/add-cilindro.component';
import { CilindroService } from '../../services/cilindro.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ListCilindrosComponent } from './cilindros/list-cilindros/list-cilindros.component';

@NgModule({
  declarations: [
    DashboardComponent,
    OxiyopalLayaudComponent,
    ControlCilindroComponent,
    AddCilindroComponent,
    ListCilindrosComponent],
  imports: [
    ThemeModule,
    NbMenuModule,
    CommonModule,
    OxiyopalRoutingModule,
    Ng2SmartTableModule,
    NbCardModule,
    NbIconModule,
    NbButtonModule,
    NbInputModule,
    NbCheckboxModule,
    NbRadioModule,
    NbSelectModule,
    FormsModule,
    NbToastrModule,
    RouterModule,
  ],
  providers: [CilindroService],
})
export class OxiyopalModule { }
