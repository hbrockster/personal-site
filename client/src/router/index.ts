import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/about',
    name: 'About',
    redirect: '/about#about'
  }
]

const router = new VueRouter({
  routes
})

export default router
