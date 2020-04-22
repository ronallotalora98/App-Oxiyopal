import { Component, OnInit } from '@angular/core';
import { Cilindro } from '../../../../models/Cilindro';
import { CilindroService } from '../../../../services/cilindro.service';
import { CreateCilinderViewModel } from '../../../../models/CilindroViewModel/CreateCilinderViewModel';
import { NbToastrService, NbGlobalPhysicalPosition } from '@nebular/theme';
import { Router } from '@angular/router';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'ngx-add-cilindro',
  templateUrl: './add-cilindro.component.html',
  styleUrls: ['./add-cilindro.component.scss'],
})
export class AddCilindroComponent implements OnInit {

  constructor(private cilindroService: CilindroService,
    private toastrService: NbToastrService,
    private router: Router) { }

  cilindro: Cilindro;
  tamanos: string[] = ['3', '3.5', '4', '4.5', '5', '5.5', '6', '6.5', '7', '7.5', '8', '8.5', '9'];
  creteViewModel: CreateCilinderViewModel;
  click = false;
  private alert: any;
  ngOnInit() {
    this.cilindro = new Cilindro;
    this.cilindroService.GetStatusAndTypeProduc().subscribe(res => {
      this.creteViewModel = res;
    });
  }

  saveCilinder() {
    this.click = true;
    if (this.cilindro.tipoDeProductoId && this.cilindro.estadoId && this.cilindro.serial && this.cilindro.cantidad) {
      this.cilindroService.CreateNewCilinder(this.cilindro).subscribe(res => {
        this.router.navigate(['/oxi/cilindros']);
      });
    } else {
      this.alert = this.toastrService.show(
        'Completa los campos que estan en rojo',
        'Falta completar algunos campos del Formulario',
        { status: 'danger', duration: 5000, position: NbGlobalPhysicalPosition.TOP_RIGHT });
      return;
    }
  }
}
