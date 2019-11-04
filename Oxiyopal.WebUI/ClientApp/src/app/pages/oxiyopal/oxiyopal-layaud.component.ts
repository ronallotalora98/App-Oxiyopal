import { Component, OnInit } from '@angular/core';
import { MENU_ITEMS } from './oxiyopal-menu';

@Component({
  selector: 'ngx-oxiyopal-layaud',
  templateUrl: './oxiyopal-layaud.component.html',
  styleUrls: ['./oxiyopal-layaud.component.scss'],
})
export class OxiyopalLayaudComponent implements OnInit {

  constructor() { }
  menu = MENU_ITEMS;
  ngOnInit() {
  }

}
