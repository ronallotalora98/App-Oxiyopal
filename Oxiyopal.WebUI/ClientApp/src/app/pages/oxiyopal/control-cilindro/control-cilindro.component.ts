import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'ngx-control-cilindro',
  templateUrl: './control-cilindro.component.html',
  styleUrls: ['./control-cilindro.component.scss']
})
export class ControlCilindroComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
  goToList(type: string) {
    this.router.navigate(['/oxi/list-cilindros/' + type]);
  }
}
