import { Component, OnInit } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'ngx-list-cilindros',
  templateUrl: './list-cilindros.component.html',
  styleUrls: ['./list-cilindros.component.scss']
})
export class ListCilindrosComponent implements OnInit {

  typeCilinder: string;
  filtrarCilindro: string;
  constructor(private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.activateRoute.params.subscribe(params => {
      this.typeCilinder = params.type;
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
      location: {
        title: 'Ubicacion',
        type: 'string',
      },
      area: {
        title: 'Area',
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
        location: 'l' + i,
        area: 'a', i,
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
        field: 'location',
        search: query,
      },
      {
        field: 'area',
        search: query,
      },
    ], false);
  }
}
