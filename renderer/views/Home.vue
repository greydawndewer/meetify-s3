<template>
  <div class="home">
    <header></header> <!-- Include the Header component -->
    <div class="content">
      <h1>Welcome to the Home Page</h1>
      <p>This is the content of the home page.</p>
    </div>
  </div>
</template>

<script>
import Header from '../components/Header.vue'; // Import the Header component

export default {
  components: {
    Header // Register the Header component
  }
};
</script>

<style scoped>
/* CSS styles for the Home component */
.home {
  /* Styles for the home page container */
}
.content {
  /* Styles for the content section */
}
</style>