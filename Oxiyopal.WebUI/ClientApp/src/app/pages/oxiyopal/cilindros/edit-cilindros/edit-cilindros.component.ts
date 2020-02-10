import { Component, OnInit } from '@angular/core';
import { CilindroService } from '../../../../services/cilindro.service';
import { Cilindro } from '../../../../models/Cilindro';

@Component({
  selector: 'ngx-edit-cilindros',
  templateUrl: './edit-cilindros.component.html',
  styleUrls: ['./edit-cilindros.component.scss']
})
export class EditCilindrosComponent implements OnInit {

  constructor(private cilindroService: CilindroService) { }
  cilindro: Cilindro;
  ngOnInit() {
    this.cilindro = new Cilindro;
  }

}
