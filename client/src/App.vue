<template>
  <div>
    <NavigationBar />
    <Introduction />
  </div>
</template>

<script lang="ts">

import { Options, Vue } from 'vue-class-component';
import NavigationBar from './components/NavigationBar.vue';
import Introduction from './components/Introduction.vue';

@Options({
  components: {
    NavigationBar,
    Introduction,
  },
})
export default class App extends Vue {}
</script>

<style lang="scss">
@import '@/assets/buttons.scss';
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
