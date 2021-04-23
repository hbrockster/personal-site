import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { IPersonApi, PersonApi } from '@/api/Person';
const personApi: IPersonApi = new PersonApi() ;
Vue.config.productionTip = false;
Vue.use(() => personApi);

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
