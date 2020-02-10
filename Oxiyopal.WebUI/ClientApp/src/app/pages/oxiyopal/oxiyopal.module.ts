import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import { NgxSpinnerModule } from 'ngx-spinner';

import { OxiyopalRoutingModule } from './oxiyopal-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ThemeModule } from '../../@theme/theme.module';
import { NbMenuModule, NbCardModule, NbIconModule, NbButtonModule,
   NbInputModule, NbCheckboxModule, NbRadioModule, NbSelectModule,
    NbToastrModule } from '@nebular/theme';
import { ControlCilindroComponent } from './control-cilindro/control-cilindro.component';
import { AddCilindroComponent } from './cilindros/add-cilindro/add-cilindro.component';
import { CilindroService } from '../../services/cilindro.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ListCilindrosComponent } from './cilindros/list-cilindros/list-cilindros.component';
import { AddClienteComponent } from './clientes/add-cliente/add-cliente.component';
import { ListClienteComponent } from './clientes/list-cliente/list-cliente.component';
import { ClienteService } from '../../services/cliente.service';
import { EditCilindrosComponent } from './cilindros/edit-cilindros/edit-cilindros.component';
import { StatisticOxiyopalModule } from './dashboard/statistic-oxiyopal.module';


@NgModule({
  declarations: [
    DashboardComponent,
    OxiyopalLayaudComponent,
    ControlCilindroComponent,
    AddCilindroComponent,
    ListCilindrosComponent,
    AddClienteComponent,
    ListClienteComponent,
    EditCilindrosComponent],
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
    StatisticOxiyopalModule,
    NgxSpinnerModule,
  ],
  providers: [CilindroService, ClienteService],
})
export class OxiyopalModule { }
