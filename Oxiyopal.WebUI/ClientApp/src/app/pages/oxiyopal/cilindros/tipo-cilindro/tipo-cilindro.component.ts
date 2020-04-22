import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'ngx-tipo-cilindro',
  templateUrl: './tipo-cilindro.component.html',
  styleUrls: ['./tipo-cilindro.component.scss']
})
export class TipoCilindroComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
  goToList(type: string) {
    this.router.navigate(['/oxi/cilindros/list-cilindros/' + type]);
  }

}
