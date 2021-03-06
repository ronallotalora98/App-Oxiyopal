import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../../../models/Cliente';
import { NbToastrService, NbGlobalPhysicalPosition } from '@nebular/theme';
import { ClienteService } from '../../../../services/cliente.service';
import { Router } from '@angular/router';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'ngx-add-cliente',
  templateUrl: './add-cliente.component.html',
  styleUrls: ['./add-cliente.component.scss']
})
export class AddClienteComponent implements OnInit {

  constructor(private toastrService: NbToastrService,
    private clienteService: ClienteService,
    private router: Router) { }
  cliente: Cliente;
  click = false;
  private alert: any;
  ngOnInit() {
    this.cliente = new Cliente;
    this.cliente.esEmpresa = false;
  }

  toggle(checked: boolean) {
    this.cliente.esEmpresa = checked;
  }

  saveCliente() {
    this.click = true;
    if (this.cliente.nombre && this.cliente.documento && this.cliente.direccion && this.cliente.telefono) {
      this.clienteService.CreateNewClient(this.cliente).subscribe(res => {
        this.router.navigate(['/oxi/clientes']);
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
