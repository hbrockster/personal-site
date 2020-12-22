<template>
  <div>
    <NavigationBar />
    <div class="main-content">
      <Introduction />
      <HelloWorld msg="Hunter to Your Vue.js App" />
      <HelloWorld msg="Hunter to Your Vue.js App" />
      <HelloWorld id="hunter" msg="Hunter to Your Vue.js App" />
    </div>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";
import Introduction from "./components/Introduction.vue";
import NavigationBar from "./components/NavigationBar.vue";

export default {
  name: "App",
  components: {
    HelloWorld,
    NavigationBar,
    Introduction
  }
};
</script>

<style lang="scss">
@import "@/assets/default.scss";
.main-content {
  padding: 1rem 1rem 1rem 1rem;
}
</style>
