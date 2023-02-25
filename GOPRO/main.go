package GOPRO

import (
	"GOPRO/controllers"
	models "GOPRO/models"
)

func main() {
	r := gin.Default()
	models.con

	r.GET("/api/tasks", controllers.FindTasks())
	r.POST("/api/tasks", controllers.CreateTask())
	r.GET("/api/tasks/one", controllers.FindTask())
	r.PUT("/api/tasks/update", controllers.UpdateTask())
	r.Run()
}
