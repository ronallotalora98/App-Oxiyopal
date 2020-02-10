import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { takeWhile } from 'rxjs/operators';
import { OrdersProfitChartData, OrderProfitChartSummary } from '../../../../@core/data/orders-profit-chart';
import { ProfitChart } from '../../../../@core/data/profit-chart';
import { OrdersChart } from '../../../../@core/data/orders-chart';





@Component({
  selector: 'ngx-ventas',
  templateUrl: './ventas.component.html',
  styleUrls: ['./ventas.component.scss'],
})
export class VentasComponent implements OnInit, OnDestroy {
  private alive = true;

  sales: Sales[] = [{
    title: 'Año',
    value: 3100,
  },
  {
    title: 'Mes',
    value: 2100,
  },
  {
    title: 'Semana',
    value: 900,
  },
  {
    title: 'Hoy',
    value: 100,
  }];
  period: string = 'Semana';
  ordersChartData: OrdersChart;
  profitChartData: ProfitChart;

  types: string[] = ['Semana', 'Mes', 'Año'];


  constructor() {

  }
  ngOnInit() {
  }
  setPeriodAndGetChartData(value: string): void {
    if (this.period !== value) {
      this.period = value;
    }
  }

  changeTab(selectedTab) {
    if (selectedTab.tabTitle === 'Profit') {
      // this.profitChart.resizeChart();
    } else {
      // this.ordersChart.resizeChart();
    }
  }

  ngOnDestroy() {
    this.alive = false;
  }

}
export class Sales {
  title: string;
  value: number;
}
