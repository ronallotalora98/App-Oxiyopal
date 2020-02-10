import { AfterViewInit, Component, Input, OnChanges, OnDestroy, OnInit } from '@angular/core';


@Component({
  selector: 'ngx-orders-chart',
  templateUrl: './orders-chart.component.html',
  styleUrls: ['./orders-chart.component.scss'],
})
export class OrdersChartComponent implements OnInit, OnDestroy, OnChanges {


  constructor() {

  }
  private alive = true;
  echartsIntance: any;
  option: any;

  ngOnInit() {
    this.updateOrdersChartOptions();
  }
  ngOnChanges(): void {
    if (this.option) {
      this.updateOrdersChartOptions();
    }
  }

  updateOrdersChartOptions() {
    this.option = {
      xAxis: {
        type: 'category',
        boundaryGap: false,
        data: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun']
      },
      tooltip: {
        trigger: 'axis',
        axisPointer: {
          type: 'cross',
          label: {
            backgroundColor: '#6a7985',
          },
        },
      },
      yAxis: {
        type: 'value',
      },
      series: [
        {
          name: 'Prubeas',
          data: [820, 932, 901, 934, 1290, 1330, 1320],
          type: 'line',
          itemStyle: {
            normal: {
              color: '#8ec6ad',
            },
          },
          areaStyle: { normal: { color: '#F1F3DB' } },
          smooth: true,
          stack: '#00d68f',
        },
        // Example
        {
          data: [600, 200, 500, 100, 800, 400, 300],
          type: 'line',
          name: 'Ronall',
          itemStyle: {
            normal: {
              opacity: 0,
            },
            emphasis: {
              color: '#ffffff',
              borderColor: '#00FFFD',
              borderWidth: 2,
              opacity: 1,
            },
          },
          lineStyle: {
            normal: {
              width: 4,
              color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                offset: 0,
                color: '#00FFFD',
              }, {
                offset: 1,
                color: '#00FFFD',
              }]),
            },
          },
          areaStyle: {
            normal: {
              color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                offset: 0,
                color: '#C9EFEF',
              }, {
                offset: 1,
                color: '#DEDEDE',
              }]),
              opacity: 1,
            },
          },
          smooth: true,
        }],
    };
  }
  onChartInit(echarts) {
    this.echartsIntance = echarts;
  }
  ngOnDestroy() {
    this.alive = false;
  }

}
