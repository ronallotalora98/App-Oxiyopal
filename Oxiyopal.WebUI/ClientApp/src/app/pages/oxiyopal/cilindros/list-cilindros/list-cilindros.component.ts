import { Component, OnInit } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { ActivatedRoute } from '@angular/router';
import { CilindroService } from '../../../../services/cilindro.service';
import { CilindroSearhResultViewModel } from '../../../../models/CilindroViewModel/CilindroSearhResultViewModel';

@Component({
  selector: 'ngx-list-cilindros',
  templateUrl: './list-cilindros.component.html',
  styleUrls: ['./list-cilindros.component.scss']
})
export class ListCilindrosComponent implements OnInit {

  typeCilinder: string;
  filtrarCilindro: string;
  constructor(private activateRoute: ActivatedRoute,
              private cilindroService: CilindroService) { }

  cilindroResult:CilindroSearhResultViewModel;
  ngOnInit() {
    this.activateRoute.params.subscribe(params => {
      this.typeCilinder = params.type;

      this.cilindroService.GetCilindersForType(this.typeCilinder).subscribe(res=>{
        this.cilindroResult = res;
        console.log(this.cilindroResult);
      });
    });
    this.loadTable();
  }

  settings = {
    actions: {
      columnTitle: 'Actions',
      add: false,
      edit: false,
      delete: false,
      custom: [
        { name: 'viewrecord', title: '<i class="fas fa-paper-plane enviar"></i>' },
        { name: 'editrecord', title: '&nbsp;&nbsp;<i class="fas fa-edit ver"></i>' },
      ],
      position: 'right',
    },
    hideSubHeader: true,
    pager: {
      display: true,
      perPage: 15,
    },
    columns: {
      id: {
        title: 'ID',
        type: 'number',
      },
      serial: {
        title: 'Serial',
        type: 'string',
      },
      ubicacion: {
        title: 'Ubicación',
        type: 'string',
      },
      donde: {
        title: 'Donde',
        type: 'string',
      },
      desde: {
        title: 'Desde',
        type: 'string',
      },
    },
  };
  data = [];
  source: LocalDataSource = new LocalDataSource();

  loadTable() {
    for (let i = 0; i < 50; i++) {
      this.data.push({
        id: i,
        serial: 'l' + i,
        ubicacion: 'a' + i,
        donde: 'd' + i,
        desde : 'c' + i,
      });
    }
    this.source.load(this.data);
  }
  onCustomAction(event) {
    switch (event.action) {
      case 'viewrecord':
        /// Ver
        break;
      case 'editrecord':
      // Editar
    }
  }

  onSearch(query: string = '') {
    // tslint:disable-next-line: triple-equals
    if (query == '') {
      this.source = new LocalDataSource();
      this.source.load(this.data);
      return;
    }
    this.source.setFilter([
      // fields we want to include in the search
      {
        field: 'id',
        search: query,
      },
      {
        field: 'serial',
        search: query,
      },
      {
        field: 'ubicacion',
        search: query,
      },
      {
        field: 'donde',
        search: query,
      },
      {
        field: 'desde',
        search: query,
      },
    ], false);
  }
}