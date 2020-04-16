import { Component, OnInit } from '@angular/core';
import { CilindroService } from '../../../../services/cilindro.service';
import { Cilindro } from '../../../../models/Cilindro';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'ngx-edit-cilindros',
  templateUrl: './edit-cilindros.component.html',
  styleUrls: ['./edit-cilindros.component.scss']
})
export class EditCilindrosComponent implements OnInit {

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
