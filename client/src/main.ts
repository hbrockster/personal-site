import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { PersonApi } from '@/api/Person';
import { IPersonApi } from '@/api/Person/IPersonApi';
const personApi: IPersonApi = new PersonApi();
Vue.config.productionTip = false;

declare module 'vue/types/vue' {
  // 3. Declare augmentation for Vue
  interface Vue {
    $personApi: IPersonApi
  }
}

new Vue({
  router,
  render: h => h(App)
}).$mount('#app').$personApi = personApi;

