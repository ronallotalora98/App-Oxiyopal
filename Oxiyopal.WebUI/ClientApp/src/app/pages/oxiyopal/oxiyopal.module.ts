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
import { CilindroService } from '../../services/cilindro.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ClienteService } from '../../services/cliente.service';
import { StatisticOxiyopalModule } from './dashboard/statistic-oxiyopal.module';
// import { EditCilidrosModule } from './cilindros/edit-cilindros/edit-cilidros.module';
import { OxiCilindrosModule } from './cilindros/oxi-cilindros.module';
import { OxiClientesModule } from './clientes/oxi-clientes.module';


@NgModule({
  declarations: [
    DashboardComponent,
    OxiyopalLayaudComponent,
    ],
  imports: [
     OxiCilindrosModule,
     OxiClientesModule,
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
