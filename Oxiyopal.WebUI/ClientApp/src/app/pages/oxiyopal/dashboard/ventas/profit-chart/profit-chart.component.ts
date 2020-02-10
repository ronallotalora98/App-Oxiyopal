import { AfterViewInit, Component, Input, OnChanges, OnDestroy, OnInit } from '@angular/core';
import { ProfitChart } from '../../../../../@core/data/profit-chart';


@Component({
  selector: 'ngx-profit-chart',
  templateUrl: './profit-chart.component.html',
  styleUrls: ['./profit-chart.component.scss']
})
export class ProfitChartComponent implements OnInit, OnDestroy, OnChanges {
  @Input()
  profitChartData: ProfitChart;
  types: string[] = ['Dia', 'Semana', 'Mes', 'Año'];
  tipe: string = 'Dia';
  productos: Productos[] = [{
    name: 'Oxigeno',
    value: 50,
    percent: 10,
    up: true,
  },
  {
    name: 'Acetileno',
    value: 20,
    percent: 10,
    up: true,
  },
  {
    name: 'Mezcla',
    value: 19,
    percent: 10,
    up: false,
  },
  {
    name: 'Argon',
    value: 12,
    percent: 10,
    up: false,
  },
  {
    name: 'Nitrogeno',
    value: 22,
    percent: 10,
    up: true,
  },
  {
    name: 'Co2',
    value: 3,
    percent: 50,
    up: false,
  }];
  private alive = true;

  echartsIntance: any;
  options: any = {};

  constructor() {

  }
  ngOnInit() {

  }
  ngOnChanges(): void {
    if (this.echartsIntance) {
    }
  }

  ngOnDestroy(): void {
    this.alive = false;
  }
}

export class Productos {
  name: string;
  value: number;
  percent: number;
  up: boolean;
}
