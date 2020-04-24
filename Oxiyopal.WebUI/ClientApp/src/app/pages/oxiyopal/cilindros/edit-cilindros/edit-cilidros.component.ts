import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CilindroService } from '../../../../services/cilindro.service';
import { Cilindro } from '../../../../models/Cilindro';
import { CilindroEditViewModel } from '../../../../models/CilindroViewModel/CilindroEditViewModel';
import { CreateCilinderViewModel } from '../../../../models/CilindroViewModel/CreateCilinderViewModel';
import { LocationResult } from '../../../../models/CilindroViewModel/LocationResul';

@Component({
  selector: 'ngx-edit-cilidros',
  templateUrl: './edit-cilidros.component.html',
  styleUrls: ['./edit-cilidros.component.scss']
})
export class EditCilidrosComponent implements OnInit {

  constructor(private cilindroService: CilindroService,
    private activateRoute: ActivatedRoute) { }

  public result: CilindroEditViewModel;
  public cantidades: string[] = ['3', '3.5', '4', '4.5', '5', '5.5', '6', '6.5', '7', '7.5', '8', '8.5', '9'];
  public creteViewModel: CreateCilinderViewModel;
  public locationResult: LocationResult;
  ngOnInit() {
    this.getData();
  }
  getData() {
    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }
      const cilindroId = params['id'];
      this.cilindroService.GetCilindro(cilindroId).subscribe(res => {
        this.result = res;
        this.getLocations(this.result.ubicacion.isBodega);
      });

      this.cilindroService.GetStatusAndTypeProduc().subscribe(res => {
        this.creteViewModel = res;
      });

    });
  }

  getLocations(isBodega: boolean) {
    this.cilindroService.GetLocations(isBodega).subscribe(data => {
      this.locationResult = data;
    });
  }
}
