import { Component } from '@angular/core';
export class LoadScript {

    public run(){
        this.loadScript('https://code.jquery.com/jquery-3.5.1.slim.min.js');
            this.loadScript('https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js');
            this.loadScript('assets/dist/js/scripts.js');
            this.loadScript('https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js');
            this.loadScript('assets/dist/assets/demo/chart-area-demo.js');
            this.loadScript('assets/dist/assets/demo/chart-bar-demo.js');
            this.loadScript('https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js');
            this.loadScript('https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js');
            this.loadScript('assets/dist/assets/demo/datatables-demo.js');
    }
    public loadScript(url: string) {
        const body = <HTMLDivElement> document.body;
        const script = document.createElement('script');
        script.innerHTML = '';
        script.src = url;
        script.async = false;
        script.defer = true;
        body.appendChild(script);
        }
        public run2(component:string){
            this.loadScript2('https://code.jquery.com/jquery-3.5.1.slim.min.js',component);
            this.loadScript2('https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js',component);
            this.loadScript2('assets/dist/js/scripts.js',component);
            this.loadScript2('https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js',component);
            this.loadScript2('assets/dist/assets/demo/chart-area-demo.js',component);
            this.loadScript2('assets/dist/assets/demo/chart-bar-demo.js',component);
            this.loadScript2('https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js',component);
            this.loadScript2('https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js',component);
            this.loadScript2('assets/dist/assets/demo/datatables-demo.js',component);
            // this.loadScript2('',component);


        }
        public loadScript2(url: string,component:string) {
          const body = <HTMLDivElement> document.getElementsByTagName(component)[0];
          const script = document.createElement('script');
          script.innerHTML = '';
          script.src = url;
          script.async = false;
          script.defer = true;
          body.appendChild(script);
        }
}
