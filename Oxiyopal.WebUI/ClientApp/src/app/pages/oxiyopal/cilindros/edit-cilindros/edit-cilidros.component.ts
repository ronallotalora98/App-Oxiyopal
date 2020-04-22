import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CilindroService } from '../../../../services/cilindro.service';
import { Cilindro } from '../../../../models/Cilindro';

@Component({
  selector: 'ngx-edit-cilidros',
  templateUrl: './edit-cilidros.component.html',
  styleUrls: ['./edit-cilidros.component.scss']
})
export class EditCilidrosComponent implements OnInit {

  constructor(private cilindroService: CilindroService,
    private activateRoute: ActivatedRoute) { }
  cilindro: Cilindro;
  ngOnInit() {
    this.cilindro = new Cilindro;
    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }
      const cilindroId = params['id'];
      this.cilindroService.GetCilindro(cilindroId).subscribe(res => {
        console.log(res);
      });

    });
  }
}
