import { Component, OnInit } from '@angular/core';
import { MENU_ITEMS } from '../oxiyopal-menu';

@Component({
  selector: 'ngx-oxi-cilindros',
  templateUrl: './oxi-cilindros.component.html',
  styleUrls: ['./oxi-cilindros.component.scss']
})
export class OxiCilindrosComponent implements OnInit {

  constructor() { }

  menu = MENU_ITEMS;
  ngOnInit() {
  }

}
