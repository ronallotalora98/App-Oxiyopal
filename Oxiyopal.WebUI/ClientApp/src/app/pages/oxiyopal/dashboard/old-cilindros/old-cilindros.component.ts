import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'ngx-old-cilindros',
  templateUrl: './old-cilindros.component.html',
  styleUrls: ['./old-cilindros.component.scss']
})
export class OldCilindrosComponent implements OnInit {

  constructor() { }
  private alive = true;

  cilindros: CilindrosResult[] = [{
    serial: '12345',
    dias: 15,
    ublicacion: 'carlos',
  },
  {
    serial: '12345',
    dias: 15,
    ublicacion: 'carlos',
  },
  {
    serial: '12345',
    dias: 15,
    ublicacion: 'carlos',
  },
  {
    serial: '12345',
    dias: 15,
    ublicacion: 'carlos',
  }];

  ngOnInit() {
  }

}
export class CilindrosResult {
  serial: string;
  dias: number;
  ublicacion: string;
}