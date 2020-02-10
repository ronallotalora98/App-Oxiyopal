import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ChartModule } from 'angular2-chartjs';
import { NgxEchartsModule } from 'ngx-echarts';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { LeafletModule } from '@asymmetrik/ngx-leaflet';

import { VentasComponent } from './ventas/ventas.component';
import { TopClientesComponent } from './top-clientes/top-clientes.component';
import { OldCilindrosComponent } from './old-cilindros/old-cilindros.component';
import { DashboardComponent } from './dashboard.component';

import { ProfitChartComponent } from './ventas/profit-chart/profit-chart.component';
import { OrdersChartComponent } from './ventas/orders-chart/orders-chart.component';
import { ThemeModule } from '../../../@theme/theme.module';
import {
  NbCardModule, NbUserModule, NbIconModule, NbTabsetModule, NbButtonModule, NbSelectModule,
  NbListModule, NbProgressBarModule, NbCheckboxModule,
} from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';


@NgModule({
  declarations: [
    VentasComponent,
    TopClientesComponent,
    OldCilindrosComponent,
    ProfitChartComponent,
    OrdersChartComponent,
  ],
  imports: [
    CommonModule,
    ThemeModule,
    NbCardModule,
    NbUserModule,
    NbButtonModule,
    NbIconModule,
    NbTabsetModule,
    NbSelectModule,
    NbListModule,
    ChartModule,
    NbProgressBarModule,
    NgxEchartsModule,
    NgxChartsModule,
    LeafletModule,
    NbCheckboxModule,
    NbEvaIconsModule,
  ],
  exports: [
    VentasComponent,
    TopClientesComponent,
    OldCilindrosComponent,
    ProfitChartComponent,
    OrdersChartComponent,
  ],
})
export class StatisticOxiyopalModule { }
