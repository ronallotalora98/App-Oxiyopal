import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Ng2SmartTableModule } from 'ng2-smart-table';

import { OxiyopalRoutingModule } from './oxiyopal-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';
import { ThemeModule } from '../../@theme/theme.module';
import { NbMenuModule } from '@nebular/theme';

@NgModule({
  declarations: [
    DashboardComponent,
    OxiyopalLayaudComponent],
  imports: [
    ThemeModule,
    NbMenuModule,
    CommonModule,
    OxiyopalRoutingModule,
    Ng2SmartTableModule,
  ],
})
export class OxiyopalModule { }
